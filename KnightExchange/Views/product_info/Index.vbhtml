@ModelType IEnumerable(Of KnightExchange.product_info)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.product_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.product_description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.product_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.product_description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.productinfo_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.productinfo_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.productinfo_id })
        </td>
    </tr>
Next

</table>
