@ModelType IEnumerable(Of cours)
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
            @Html.DisplayNameFor(Function(model) model.course_id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.course_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.instructor_lname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.course_id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.course_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.instructor_lname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.crn }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.crn }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.crn })
        </td>
    </tr>
Next

</table>
