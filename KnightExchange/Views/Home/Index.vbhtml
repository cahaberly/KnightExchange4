@Code
    ViewData("Title") = "KnightExchange"
End Code

<div class="jumbotron">
    <h1>Knight Exchange</h1>
    <div style="float:left;"><img src="~/Images/KnightExchangeLogo.png" style="width: 300px; height: 248px;" /></div>
    <p class="lead">Welcome to the Knight Exchange!!
Your place to trade books, supplies and find tutoring</p>
    
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Getting started</h2>
        <p>
            Interested in joining the exchange? Click here to find out more.
        </p>
        <p>
            <button class="btn btn-default" type="button" onclick="location.href='@Url.Action("Contact", "Home")'">
            Contact Us &raquo;
            </button>
        </p>
    </div>
    <div class="col-md-4">
        <h2>Get more libraries</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
    </div>
</div>
