@ModelType supply
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>supply</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_number, "user_number", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("user_number", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.user_number)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.crn, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.crn)
                @Html.ValidationMessageFor(Function(model) model.crn)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.make, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.make)
                @Html.ValidationMessageFor(Function(model) model.make)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.model, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.model)
                @Html.ValidationMessageFor(Function(model) model.model)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.description)
                @Html.ValidationMessageFor(Function(model) model.description)
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
