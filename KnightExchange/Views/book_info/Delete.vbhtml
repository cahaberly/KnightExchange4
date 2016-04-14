@ModelType KnightExchange.book_info
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>book_info</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.book_title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book_edition)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_edition)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book_isbn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_isbn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book_author)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_author)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
