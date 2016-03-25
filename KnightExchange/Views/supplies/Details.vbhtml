@ModelType supply
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>supply</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.crn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.crn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.make)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.make)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.supply_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
