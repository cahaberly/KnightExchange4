@ModelType service
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>service</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.service_number)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_number, "user_number", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("user_number", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.user_number)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.service_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.service_name)
                @Html.ValidationMessageFor(Function(model) model.service_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.service_description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.service_description)
                @Html.ValidationMessageFor(Function(model) model.service_description)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.trade_for, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.trade_for)
                @Html.ValidationMessageFor(Function(model) model.trade_for)
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
