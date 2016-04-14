@ModelType IEnumerable(Of KnightExchange.book_info)
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
            @Html.DisplayNameFor(Function(model) model.book_title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book_edition)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book_isbn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book_author)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book_title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book_edition)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book_isbn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book_author)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.bookinfo_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.bookinfo_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.bookinfo_id })
        </td>
    </tr>
Next

</table>
