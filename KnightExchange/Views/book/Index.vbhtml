@ModelType IEnumerable(Of book)
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
            @Html.DisplayNameFor(Function(model) model.isbn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.edition)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.author)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.cours.course_id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user.user_fname)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.isbn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.edition)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.author)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.cours.course_id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user.user_fname)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.book_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.book_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.book_id })
        </td>
    </tr>
Next

</table>
