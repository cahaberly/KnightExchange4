@ModelType IEnumerable(Of supply)
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
            @Html.DisplayNameFor(Function(model) model.crn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.make)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user.user_fname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.crn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.make)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user.user_fname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.supply_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.supply_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.supply_id })
        </td>
    </tr>
Next

</table>
