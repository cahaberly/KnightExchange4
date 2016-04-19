@ModelType IEnumerable(Of KnightExchange.book_info)

@Code
    ViewData("Title") = "Books"
End Code

<h2>Books Available</h2>

<div class="book">
    @For Each item In Model
        @<h3>@Html.DisplayFor(Function(modelItem) item.book_title)</h3>
        @<blockquote>
            <em style="font-size:small;">
                Author: @Html.ActionLink(item.book_author, "authors", "KnightExchange", New With {.id = item.book_author})
                        
                                </em></blockquote>
    Next
</div>



