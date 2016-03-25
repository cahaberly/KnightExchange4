@ModelType book
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>book</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.isbn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.isbn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.edition)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.edition)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.author)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.author)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.cours.course_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cours.course_id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user.user_fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user.user_fname)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.book_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
