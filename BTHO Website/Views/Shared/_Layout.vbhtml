<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta id="meta" name="viewport" content="width=device-width, initial-scale=1.0" />

    <meta charset="UTF-8">
   <title>Bridge to Homeownership</title>


 
    <link rel="stylesheet" href="~/Content/menucss2.css" type="text/css" />
    <link rel="stylesheet" type="text/css" href="~/Content/site.css" />
    <link rel="stylesheet" type="text/css" href="~/Content/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="~/Content/reset-min.css" />
    <script src="~/Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="~/Scripts/bootstrap.js" type="text/javascript"></script>
    <script type="text/javascript" src="~/Scripts/hoverintent.js"></script>
    <link rel="stylesheet" href="~/Content/font-awesome.min.css">
    
  
    <script type='text/javascript'>
        var appInsights = window.appInsights || function (config) {
            function r(config) { t[config] = function () { var i = arguments; t.queue.push(function () { t[config].apply(t, i) }) } }
            var t = { config: config }, u = document, e = window, o = 'script', s = u.createElement(o), i, f; for (s.src = config.url || '//az416426.vo.msecnd.net/scripts/a/ai.0.js', u.getElementsByTagName(o)[0].parentNode.appendChild(s), t.cookie = u.cookie, t.queue = [], i = ['Event', 'Exception', 'Metric', 'PageView', 'Trace', 'Ajax']; i.length;)r('track' + i.pop()); return r('setAuthenticatedUserContext'), r('clearAuthenticatedUserContext'), config.disableExceptionTracking || (i = 'onerror', r('_' + i), f = e[i], e[i] = function (config, r, u, e, o) { var s = f && f(config, r, u, e, o); return s !== !0 && t['_' + i](config, r, u, e, o), s }), t
        }({
            instrumentationKey: 'ae5ab214-1f12-4d07-94bb-a1b277956b1a'
        });

        window.appInsights = appInsights;
        appInsights.trackPageView();
    </script>

    
</head>
<body class="admin_area" style="font-family:Helvetica,Arial,sans-serif;">





    <div id="banner">
        <a href="Home.html"><img class="logo" src="images/btho_main_logo.svg" alt="Bridge to Homeownership" /></a>
    </div>
  
    <div class="menubutton">Menu</div><nav id="sitemenu">
        <ul class="flexnav" data-breakpoint="800">
            <li>
                <a class="mainfoldericon" href="index.html">Home</a>
            </li>
            <li>
                <a class="mainfoldericon" href="How-the-Program-Works.html">Learn How It Works</a>
            </li>
            <li>
                <a class="mainfoldericon" href="mortgage.html">Program Benefits</a>
            </li>
            <li class="item-with-ul">
                <a class="mainfoldericon">View Our Listings</a>
                <ul>
                    <li>
                        <a class="subfoldericon" href="View-Our-Listings/View-Inventory.html">View Inventory</a>
                    </li>
                    <li>
                        <a class="subfoldericon" href="View-Our-Listings/Our-Communities.html">Our Communities</a>
                    </li>
                    <li>
                        <a class="subfoldericon" href="View-Our-Listings/Reidbuilt-Homes.html">ReidBuilt Homes</a>
                    </li>
                </ul>
            <li>
                <a class="mainfoldericon" href="Pre-Approved-Credit.html">Get Pre Approved Now</a>
            </li>
            <li class="item-with-ul">
                <a class="mainfoldericon">About</a>
                <ul>
                    <li>
                        <a class="subfoldericon" href="About/About-Us.html">About Us</a>
                    </li>
                    <li>
                        <a class="subfoldericon" href="About/Why-Us.html">Why Us</a>
                    </li>
                    <li>
                        <a class="subfoldericon" href="About/FAQ.html">FAQ</a>
                    </li>
                    <li>
                        <a class="subfoldericon" href="About/Privacy-Policy.html">Privacy Policy</a>
                    </li>
                </ul>
            <li>
                <a class="mainfoldericon" href="Contact-Us.html">Contact</a>
            </li>
            <li>
                <a class="mainfoldericon" href="Thank-You.html">Thank You</a>
            </li>
        </ul>
    </nav>
    <script type="text/javascript" src="~/Scripts/jquery.flexnav.js"></script>
    <script>
        var fnav = $("#sitemenu .flexnav").flexNav({
            'animationSpeed': 250,            // default for drop down animation speed
            'transitionOpacity': true,           // default for opacity animation
            'buttonSelector': '.menubutton', // default menu button class name
            'hoverIntent': true,          // Change to true for use with hoverIntent plugin
            'hoverIntentTimeout': 800,            // hoverIntent default timeout

            'calcItemWidths': false,          // dynamically calcs top level nav item widths
            'hover': true            // would you like hover support?
        });
        var fnav1 = $("#suckertreemenu1 .flexnav").flexNav({
            'animationSpeed': 250,            // default for drop down animation speed
            'transitionOpacity': true,           // default for opacity animation
            'buttonSelector': '.menu-button', // default menu button class name
            'hoverIntent': true,          // Change to true for use with hoverIntent plugin
            'hoverIntentTimeout': 150,            // hoverIntent default timeout
            'calcItemWidths': false,          // dynamically calcs top level nav item widths
            'hover': true            // would you like hover support?
        });

        if (navigator.platform == "Win16" || navigator.platform == "Win32" || navigator.platform == "WinCE") {
            $("html").addClass("platform_windows");
        }

    </script>
    
    <div id="container">
        <div id="maincontent">
            <div id="page_info"> </div>
            <div id="content" style="">
                <div style="width: 100%; margin: 10px 0px;" class="content_box">
                    <div class="resultcontent">
                        <div id="resultcon_inner" style="padding-left:3px;padding-right:3px;">
                            @RenderBody
                        </div>
                        <div style="clear:both;"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="footer">
        <p id="footer_capt"></p>
        <a class="logo" href="Home.html"><img src="~/images/btho_main_logo.svg" alt="Bridge to Homeownership" data-fallback="/images/btho_logo.png" /></a>
        <ul class="text-links">
            <li><a href="Learn-How-It-Works.html">How The Program Works</a></li>
            <li><a href="Get-Pre-Approved-Now.html">The Program - Get Pre-Approved Today</a></li>
            <li><a href="view-our-listings.html">Inventory</a></li>
            <li><a href="View-Our-Listings/ReidBuilt-Homes-2.html">ReidBuilt Homes</a></li>
        </ul>
        <ul class="text-links">
            <li><a href="About.html">About Us</a></li>
            <li><a href="About/Why-Us.html">Why Us</a></li>
        </ul>
        <ul class="text-links">
            <li><a href="Contact.html">Contact Us</a></li>
            <li><a href="About/FAQ.html">FAQ</a></li>
            <li><a href="About/Privacy-Policy.html">Privacy Policy</a></li>
        </ul>
        
    </div>
</body>
</html>
