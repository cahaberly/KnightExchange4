@ModelType service
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>service</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.service_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.service_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.service_description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.service_description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.trade_for)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.trade_for)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.service_number }) |
    @Html.ActionLink("Back to List", "Index")
</p>
