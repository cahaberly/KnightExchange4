@ModelType user
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>user</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_fname, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_fname)
                @Html.ValidationMessageFor(Function(model) model.user_fname)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_lname, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_lname)
                @Html.ValidationMessageFor(Function(model) model.user_lname)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_email, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_email)
                @Html.ValidationMessageFor(Function(model) model.user_email)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_phone, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_phone)
                @Html.ValidationMessageFor(Function(model) model.user_phone)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_level, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_level)
                @Html.ValidationMessageFor(Function(model) model.user_level)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_pswd, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_pswd)
                @Html.ValidationMessageFor(Function(model) model.user_pswd)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.auth_level, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.auth_level)
                @Html.ValidationMessageFor(Function(model) model.auth_level)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.auth_desc, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.auth_desc)
                @Html.ValidationMessageFor(Function(model) model.auth_desc)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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
