/*
 * Photo Box
 * Author: http://photoboxone.com/
 */
 
jQuery(document).ready(function($){
	var tgm_media_frame_img,
		clicked_on_imgbtn = false,
		btn = $('#vnho_upload_image_button'),
		button_text = btn.text(),
		button_title = btn.attr('title');
		
	if( typeof button_text == 'undefined' || button_text == '' ){
		button_text = 'Choose images';
	}
	if( typeof button_title == 'undefined' || button_title == '' ){
		button_title = 'Upload images';
	}
	
    $(document.body).on('click.tgmOpenMediaManager', '#vnho_upload_image_button', function(e){
        e.preventDefault();
		
        if ( tgm_media_frame_img ) {
            tgm_media_frame_img.open();
            return;
        }

        tgm_media_frame_img = wp.media.frames.tgm_media_frame = wp.media({
            className: 'media-frame tgm-media-frame',
            frame: 'select',
            multiple: true,
            title: button_title,
            library: {
                type: 'image'
            },
            button: {
                text: button_text
            }
        });

        tgm_media_frame_img.on('select', function(){
            //var media_attachment = tgm_media_frame_img.state().get('selection').first().toJSON();
			
			var ids = [],
				imgs = '';
			
			tgm_media_frame_img.state().get('selection').each(function(e,i){
				var media_attachment = e.toJSON();
				console.log(media_attachment);
				
				ids.push(media_attachment.id);
				imgs += '<img src="'+media_attachment.url+'" height=100 alt=""/>';
			});
			
            jQuery('#vnho_display_image_id').val(ids.join(','));
			jQuery('#vnho_display_image_thumb').html(imgs);
        });
		
        tgm_media_frame_img.open();
		
    });
	/* set click for remove_image_button */
	$('#vnho_remove_image_button').click(function(e) {
		e.preventDefault();
		$('#vnho_display_image_id').attr('value','');
		$('#vnho_display_image_thumb').html('');
	});
	
	$('#vnho_upload_image_button').click(function() {
		formfield = jQuery('#vnho_display_image_id').attr('name');
		clicked_on_imgbtn = true;
		// if tb_show is function
		tb_show('Add Image', 'media-upload.php?type=image&amp;TB_iframe=true');
		return false;
	});
	
});