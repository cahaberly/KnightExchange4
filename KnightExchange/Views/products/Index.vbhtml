@ModelType IEnumerable(Of KnightExchange.product)
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
            @Html.DisplayNameFor(Function(model) model.product_info.product_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user.user_lname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.product_info.product_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user.user_lname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.product_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.product_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.product_id })
        </td>
    </tr>
Next

</table>
