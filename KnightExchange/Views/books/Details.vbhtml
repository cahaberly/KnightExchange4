@ModelType KnightExchange.book
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>book</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.book_info.book_title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book_info.book_title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user.user_lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user.user_lname)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.book_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
