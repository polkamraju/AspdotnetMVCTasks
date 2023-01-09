function ValidateUserRequiredFields() {
    var name = $("#txtUserName").val(), dob = $("#txtUserDOB").val(), nationality = $("#txtUserNationality").val(), ddlCountry = $("#ddlUserCountry").val(),
        txtCountry = $("#txtUserCountry").val(), address = $("#taUserAddress").val(), skills = $("#taUserSkills").val();
    if (IsEmpty(name) || IsEmpty(dob) || IsEmpty(nationality) || IsEmpty(address) || IsEmpty(skills)
        || ((IsEmptyOrZero(ddlCountry) && ddlCountry != -1) || (ddlCountry == -1 && IsEmpty(txtCountry))))
        return false;
    else
        return true;
}
$("#btnUserCreation").click(function () {        
    var isValidated = ValidateUserRequiredFields();
    if (!isValidated)
    {        
        alert("Please provide information of all mandatory fields.");
    }
    else {
        var name = $("#txtUserName").val();
        localStorage.setItem["Username"] = name;
        $('#spanCreatedUserName').text(name);
        alert("User created successfully.");
    }
});

function IsEmpty(val) {
    if (val == "" || val == undefined || val == "undefined" || val == null || val == "null")
        return true;
    else
        return false;
}
function IsEmptyOrZero(val) {
    if (val == "" || val == undefined || val == "undefined" || val == null || val == "null" || val == 0)
        return true;
    else
        return false;
}
