@ModelType book
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>book</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.book_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_number, "user_number", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("user_number", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.user_number)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.crn, "crn", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("crn", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.crn)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.isbn, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.isbn)
                @Html.ValidationMessageFor(Function(model) model.isbn)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.title, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.title)
                @Html.ValidationMessageFor(Function(model) model.title)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.edition, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.edition)
                @Html.ValidationMessageFor(Function(model) model.edition)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.author, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.author)
                @Html.ValidationMessageFor(Function(model) model.author)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
