@ModelType cours
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>cours</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.course_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.course_id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.course_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.course_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.instructor_lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.instructor_lname)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.crn }) |
    @Html.ActionLink("Back to List", "Index")
</p>
