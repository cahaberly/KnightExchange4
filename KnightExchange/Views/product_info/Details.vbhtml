@ModelType KnightExchange.product_info
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>product_info</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.product_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.product_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.product_description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.product_description)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.productinfo_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
