/*Toast Init*/


$(document).ready(function() {
	"use strict";
	
	$.toast({
	    heading: 'Welcome User',
	    text: 'You can Get Useful Info about Car, Also get Booking Information',
		position: 'top-right',
		loaderBg:'#fec107',
		icon: 'success',
		hideAfter: 3500, 
		stack: 6
	});
	
	$('.tst1').on('click',function(e){
	    $.toast().reset('all'); 
		$("body").removeAttr('class');
		$.toast({
            heading: '2 new messages',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-right',
            loaderBg:'#fec107',
            icon: 'info',
            hideAfter: 3000, 
            stack: 6
        });
		return false;
    });

	$('.tst2').on('click',function(e){
        $.toast().reset('all');
		$("body").removeAttr('class');
		$.toast({
            heading: 'Server not responding',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-right',
            loaderBg:'#ff2a00',
            icon: 'warning',
            hideAfter: 3500, 
            stack: 6
        });
		return false;
	});
	
	$('.tst3').on('click',function(e){
        $.toast().reset('all');
		$("body").removeAttr('class');
		$.toast({
		    heading: 'Welcome User',
		    text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-right',
            loaderBg:'#fec107',
            icon: 'success',
            hideAfter: 3500, 
            stack: 6
          });
		return false;  
	});

	$('.tst4').on('click',function(e){
		$.toast().reset('all');
		$("body").removeAttr('class');
		$.toast({
            heading: 'Opps! somthing wents wrong',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-right',
            loaderBg:'#fec107',
            icon: 'error',
            hideAfter: 3500
        });
		return false;
    });
	
	$('.tst5').on('click',function(e){
	    $.toast().reset('all');   
		$("body").removeAttr('class');
		$.toast({
            heading: 'Top Left',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-left',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
    });
	
	$('.tst6').on('click',function(e){
		$.toast().reset('all');
		$("body").removeAttr('class');
		$.toast({
            heading: 'Top Right',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-right',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
    });
	
	$('.tst7').on('click',function(e){
		$.toast().reset('all');
		$("body").removeAttr('class');
		$.toast({
            heading: 'Bottom Left',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'bottom-left',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
    });
	
	$('.tst8').on('click',function(e){
	    $.toast().reset('all');   
		$("body").removeAttr('class');
		$.toast({
            heading: 'Bottom Right',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'bottom-right',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
	});
	
	$('.tst9').on('click',function(e){
	    $.toast().reset('all');   
		$("body").removeAttr('class').removeClass("bottom-center-fullwidth").addClass("top-center-fullwidth");
		$.toast({
            heading: 'Top Center',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'top-center',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
	});
	
	$('.tst10').on('click',function(e){
	    $.toast().reset('all');
		$("body").removeAttr('class').addClass("bottom-center-fullwidth");
		$.toast({
            heading: 'Bottom Right',
            text: 'You can Get Useful Info about Car, Also get Booking Information',
            position: 'bottom-center',
            loaderBg:'#878787',
            hideAfter: 3500
        });
		return false;
	});
});
          
