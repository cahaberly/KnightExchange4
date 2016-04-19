<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - The Knight Exchange Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Knight Exchange", "Index", "Home", Nothing, New With {.[class] = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                </ul>
                <ul class="nav navbar-nav">
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Admin<b class="caret"></b></a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Books", "Index", "books")</li>
                           <li>@Html.ActionLink("Book Information", "Index", "book_info")</li>
                           <li>@Html.ActionLink("Products", "Index", "Products")</li>
                            <li>@Html.ActionLink("Product Information", "Index", "Products")</li>
                            <li>@Html.ActionLink("Users", "Index", "users")</li>
                       </ul>
                    </li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Books<b class="caret"></b></a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Books Available", "books", "KnightExchange")</li>
                            <li>@Html.ActionLink("Book Information", "bookInfo", "KnightExchange")</li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Products<b class="caret"></b></a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Products Available", "products", "KnightExchange")</li>
                            <li>@Html.ActionLink("Product Information", "productInfo", "KnightExchange")</li>
                        </ul>
                    </li>                   
                </ul>
              
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - C. Haberly, C. Bockholt, K. Jackson, K. Conethan</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
