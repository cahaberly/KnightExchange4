@ModelType IEnumerable(Of service)
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
            @Html.DisplayNameFor(Function(model) model.service_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.service_description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.trade_for)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user.user_fname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.service_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.service_description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.trade_for)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user.user_fname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.service_number }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.service_number }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.service_number })
        </td>
    </tr>
Next

</table>
