@ModelType KnightExchange.book_info
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.bookinfo_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
