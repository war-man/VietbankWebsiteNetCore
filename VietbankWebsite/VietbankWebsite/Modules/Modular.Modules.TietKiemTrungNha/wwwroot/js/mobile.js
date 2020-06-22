(function($){
	$('.widget-news-home').each(function(){
		var self = $(this),
			active = 0,
			list = $('.list-posts li',this),
			n = list.length-1;
		if( n>-1 ){
			self.append('<div class="show-on-mobile"><a class="prev" href="#"></a><a class="next" href="#"></a></div>');
			$('.list-posts li').eq(0).addClass('show');
			$('.show-on-mobile a').click(function(e){
				e.preventDefault();
				var a = $(this);
				if( a.hasClass('next') ){
					active++;
					if( active>n ){
						active = 0;
					}
				} else {
					active--;
					if( active<0 ){
						active = n;
					}
				}
				console.log('active',active);
				list.removeClass('show').eq(active).addClass('show');
			});
		}
	});
	
	$('#primary-navigation .menu-main-container').each(function(){
		var nav = $(this);
		nav.append('<div class="show-max-width-800 btn-menu-mobile">');
		$('.btn-menu-mobile',this).click(function(e){
			nav.toggleClass('open-menu');
		});
		
	});
	
	
})(jQuery);