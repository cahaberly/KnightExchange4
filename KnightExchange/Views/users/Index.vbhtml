@ModelType IEnumerable(Of KnightExchange.user)
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
            @Html.DisplayNameFor(Function(model) model.user_lname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_fname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_permission)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_lname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_fname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_permission)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.user_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.user_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.user_id })
        </td>
    </tr>
Next

</table>
