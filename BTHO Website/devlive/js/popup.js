var popupStatus = 0;

//loading popup with jQuery magic!
function loadPopup()
{
//	   document.getElementById('bigdiv').style.opacity="0.7";
//	   document.getElementById('bigdiv').style.display="block";	   
	   document.getElementById('optimize_popup').style.block="block";
}

//disabling popup with jQuery magic!
function disablePopup(){
	//disables popup only if it is enabled
	if(popupStatus==1){
	   document.getElementById('optimize_popup').style.display="none";	
	   document.getElementById('bigdiv').style.display="none";		
           window.scrollTo(ScrollLeft,ScrollTop);
	   popupStatus = 0;
	}
}

//centering popup
function centerPopup(tp){
	//request data for centering
	var html=document.getElementsByTagName('html');
	var windowWidth = document.documentElement.clientWidth;
	op=document.getElementById('optimize_popup');
	op.style.postion="absolute";
	op.style.top=tp+'px';
	op.style.display="block";	
	var popupWidth = op.offsetWidth;
	val=Math.round((windowWidth-popupWidth)/2);
	op.style.left=val+'px';
	bgdiv=document.getElementById('bigdiv');
	bgdiv.style.height=html.item(0).scrollHeight+'px';
	bgdiv.onclick=hidesettings2;
}


