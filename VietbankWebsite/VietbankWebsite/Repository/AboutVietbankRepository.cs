﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class AboutVietbankRepository : IAboutVietbankRepository
    {
        private readonly VietbankContext _context;
        public AboutVietbankRepository(VietbankContext context)
        {
            _context = context;
        }

        private int ComputePagination(int total, int pageSize)
        {
            if (total % pageSize == 0)
            {
                return total / pageSize;
            }
            else
            {
                return (total / pageSize) + 1;
            }
        }

        public async Task<ListNews> GetListNews(int idCate, string cateName, string aliasCate, string lang, int page, int pageSize)
        {
            var lstNewsItems = await (from a in _context.VbPosts
                                      join b in _context.VbPostCategories on a.Id equals b.post_ID
                                      join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                                      where b.category_ID.Equals(idCate)
                                      where c.language.Equals(lang)
                                      where a.to_ping.Equals(1)
                                      orderby a.Id descending
                                      select new ListNewsItem()
                                      {
                                          CategoryName = cateName,
                                          Title = c.post_title,
                                          Description = c.post_excerpt,
                                          Url = $"{aliasCate}/{c.post_url}",
                                          Thumbnail = a.post_thumbnail,
                                          PublishDate = a.post_date
                                      }).Skip(3).Skip(pageSize * page).Take(pageSize).ToListAsync();

            var totalSize = from a in _context.VbPosts
                            join b in _context.VbPostCategories on a.Id equals b.post_ID
                            join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                            where b.category_ID.Equals(idCate)
                            where c.language.Equals(lang)
                            where a.to_ping.Equals(1)
                            where a.post_status.Equals(4)
                            select c;
            return new ListNews()
            {
                ListNewsItems = lstNewsItems,
                PageSize = ComputePagination(await totalSize.CountAsync(), pageSize)
            };
        }

        public async Task<IntroduceDetail> IntroduceDetail(int postId, string lang)
        {
            var vbPostSeo = await _context.VbPostSeo.Where(x => x.IdPost.Equals(postId)).SingleOrDefaultAsync();
            var introduceDetail = await (from a in _context.VbPostTranslates
                                         join b in _context.VbPosts on a.post_ID equals b.Id
                                         where a.post_ID.Equals(postId)
                                         where a.language.Equals(lang)
                                         select new IntroduceDetail()
                                         {
                                             Title = a.post_title,
                                             Content = a.post_content,
                                             Image = b.ping_status ?? "/img/banner_page/vietbank-bg.jpg"
                                         }).FirstOrDefaultAsync();
            if (vbPostSeo != null)
            {
                introduceDetail.MetaTitle = vbPostSeo.MetaTitle ?? "";
                introduceDetail.MetaDescription = vbPostSeo.MetaDescription ?? "";
                
            }
            else
            {
                introduceDetail.MetaTitle = "";
                introduceDetail.MetaDescription = "";
            }
            introduceDetail.FeatureImage = introduceDetail.Image;
            return introduceDetail;
        }

        public async Task<IntroduceVietbank> IntroduceVietbank(string alias, string lang)
        {
            var introduce = await (from a in _context.VbCategories
                                   join b in _context.VbPostCategories on a.ID equals b.category_ID
                                   join d in _context.VbCategoryTranslates on a.ID equals d.category_ID
                                   join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                                   where a.slug.Equals(alias)
                                   where c.language.Equals(lang)
                                   where d.language.Equals(lang)
                                   select new IntroduceVietbank()
                                   {
                                       Title = d.name,
                                       Image = a.thumbnail ?? "/img/banner_page/vietbank-bg.jpg",
                                       Content = c.post_content
                                   }).FirstOrDefaultAsync();
            return introduce;
        }

        public async Task<LeadershipDetail> LeadershipDetail(string alias, string lang)
        {
            var postID = await _context.VbPostTranslates.Where(x => x.post_url.Equals(alias)).SingleAsync();
            var leadershipDetail = await (from a in _context.VbPostTranslates
                                          where a.post_url.Equals(alias)
                                          where a.language.Equals(lang)
                                          select new LeadershipDetail()
                                          {
                                              IdPost = a.post_ID,
                                              Title = a.post_title,
                                              Content = a.post_content
                                          }).FirstOrDefaultAsync();

            if (leadershipDetail == null)
            {
                var langTemp = lang == "vi" ? "en" : "vi";
                return await (from a in _context.VbPostTranslates
                              where a.post_ID.Equals(postID.post_ID)
                              where a.language.Equals(lang)
                              select new LeadershipDetail()
                              {
                                  IdPost = a.post_ID,
                                  Title = a.post_title,
                                  Content = a.post_content
                              }).FirstOrDefaultAsync();
            }
            var vbPostSeo = await _context.VbPostSeo.Where(x => x.IdPost.Equals(leadershipDetail.IdPost)).SingleOrDefaultAsync();
            if (vbPostSeo != null)
            {
                leadershipDetail.MetaTitle = vbPostSeo.MetaTitle ?? "";
                leadershipDetail.MetaDescription = vbPostSeo.MetaDescription ?? "";

            }
            else
            {
                leadershipDetail.MetaTitle = "";
                leadershipDetail.MetaDescription = "";
            }
            leadershipDetail.FeatureImage = "";
            return leadershipDetail;
        }

        public async Task<IEnumerable<TopThreeNewsToCate>> TopThreeNewsToCate(int idCate, string aliasCate, string lang)
        {
            int[] arrayCate = null;
            if (idCate == 0)
            {
                arrayCate = await _context.VbCategories.Where(x => x.parent_id.Equals(15)).Select(x => x.ID).ToArrayAsync();
                return await (from a in _context.VbPosts
                              join b in _context.VbPostCategories on a.Id equals b.post_ID
                              join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                              where arrayCate.Contains(b.category_ID)
                              where c.language.Equals(lang)
                              where a.to_ping.Equals(1)
                              orderby a.Id descending
                              select new TopThreeNewsToCate()
                              {
                                  Title = c.post_title,
                                  Description = c.post_excerpt,
                                  Thumbnail = a.post_thumbnail,
                                  Url = $"{aliasCate}/{c.post_url}",
                                  PublishDate = a.post_date
                              }).Take(3).ToListAsync();
            }
            return await (from a in _context.VbPosts
                          join b in _context.VbPostCategories on a.Id equals b.post_ID
                          join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                          where b.category_ID.Equals(idCate)
                          where c.language.Equals(lang)
                          where a.to_ping.Equals(1)
                          orderby a.Id descending
                          select new TopThreeNewsToCate()
                          {
                              Title = c.post_title,
                              Description = c.post_excerpt,
                              Thumbnail = a.post_thumbnail,
                              Url = $"{aliasCate}/{c.post_url}",
                              PublishDate = a.post_date
                          }).Take(3).ToListAsync();
        }

        public async Task<NewsDetail> GetNewsDetail(string alias, string lang)
        {
            var news = await (from a in _context.VbPostTranslates
                        join b in _context.VbPosts on a.post_ID equals b.Id
                        where a.post_url.Equals(alias)
                        where a.language.Equals(lang)
                        select new NewsDetail()
                        {
                            PostId = a.post_ID,
                            Title = a.post_title,
                            PublishedDate = b.post_date.ToString("dd/MM/yyyy"),
                            Content = a.post_content,
                            FeatureImage = b.post_thumbnail
                        }).SingleOrDefaultAsync();

            var vbPostSeo = await _context.VbPostSeo.Where(x => x.IdPost.Equals(news.PostId)).SingleOrDefaultAsync();
            if (vbPostSeo != null)
            {
                news.MetaTitle = vbPostSeo.MetaTitle ?? "";
                news.MetaDescription = vbPostSeo.MetaDescription ?? "";

            }
            else
            {
                news.MetaTitle = "";
                news.MetaDescription = "";
            }
            return news;
        }

        public async Task<IEnumerable<RandomNewsVietbank>> GetRamdomNewsToCategory(int idCate, string aliasCate, string lang)
        {
            var r = new Random();
            var lstPost = await _context.VbPostCategories.Where(x => x.category_ID.Equals(idCate)).Select(x => x.post_ID).ToArrayAsync();
            int[] result = new int[8];
            for (int i = 0; i < 8; i++)
            {
                var elementRand = r.Next(0, lstPost.Count() - 1);
                result[i] = lstPost.ElementAt(elementRand);
            }

            var listRandom = await (from a in _context.VbPosts
                                    join b in _context.VbPostCategories on a.Id equals b.post_ID
                                    join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                                    where b.category_ID.Equals(idCate)
                                    where a.to_ping.Equals(1)
                                    where c.language.Equals(lang)
                                    where result.Distinct().Contains(b.post_ID)
                                    where a.post_status.Equals(4)
                                    orderby a.Id descending
                                    select new RandomNewsVietbank()
                                    {
                                        Title = c.post_title,
                                        Image = a.post_thumbnail,
                                        Url = $"{aliasCate}/{c.post_url}",
                                        PublishedDate = a.post_date.ToString("dd/MM/yyyy")
                                    }).Take(5).ToListAsync();
            return listRandom;

        }

        private async Task<int[]> ListPostRandomNewsToCategory(int idCate, VietbankContext vietbankContext)
        {
            var r = new Random();
            var lstPost = await vietbankContext.VbPostCategories.Where(x => x.category_ID.Equals(idCate)).Select(x => x.post_ID).ToArrayAsync();
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                result[0] = lstPost.Where(x => !result.Contains(x)).ElementAt(r.Next(1, lstPost.Count()));
            }
            return result;
        }

        public async Task<BankCodeDataTable> GetVbBankCodes()
        {
            return new BankCodeDataTable()
            {
                Data = await _context.VbBankCodes.Where(x => x.IsInsert.Equals(0)).Where(x => x.IsUpdate.Equals(0)).ToListAsync()
            };
        }

        public async Task AddContact(Contact contact)
        {
            _context.Contact.Add(contact);
            await _context.SaveChangesAsync();
        }
    }

    public interface IAboutVietbankRepository
    {
        Task<IntroduceVietbank> IntroduceVietbank(string alias, string lang);
        Task<IntroduceDetail> IntroduceDetail(int postId, string lang);
        Task<LeadershipDetail> LeadershipDetail(string alias, string lang);
        Task<IEnumerable<TopThreeNewsToCate>> TopThreeNewsToCate(int idCate, string aliasCate, string lang);
        Task<ListNews> GetListNews(int idCate, string cateName, string aliasCate, string lang, int page, int pageSize);

        Task<NewsDetail> GetNewsDetail(string alias, string lang);
        Task<IEnumerable<RandomNewsVietbank>> GetRamdomNewsToCategory(int idCate, string aliasCate, string lang);
        Task<BankCodeDataTable> GetVbBankCodes();
        Task AddContact(Contact contact); 
    }
}
