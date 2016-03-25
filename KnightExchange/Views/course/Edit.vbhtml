@ModelType cours
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>cours</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.crn)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.course_id, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.course_id)
                @Html.ValidationMessageFor(Function(model) model.course_id)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.course_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.course_name)
                @Html.ValidationMessageFor(Function(model) model.course_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.instructor_lname, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.instructor_lname)
                @Html.ValidationMessageFor(Function(model) model.instructor_lname)
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
