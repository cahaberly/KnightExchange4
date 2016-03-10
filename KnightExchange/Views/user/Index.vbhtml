@ModelType IEnumerable(Of user)
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
            @Html.DisplayNameFor(Function(model) model.user_fname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_lname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_phone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_level)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_pswd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.auth_level)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.auth_desc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_fname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_lname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_phone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_level)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_pswd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.auth_level)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.auth_desc)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.user_number }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.user_number }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.user_number })
        </td>
    </tr>
Next

</table>
