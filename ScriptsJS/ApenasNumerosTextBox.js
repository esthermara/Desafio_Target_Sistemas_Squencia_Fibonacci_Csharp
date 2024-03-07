function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (
        (charCode >= 48 && charCode <= 57) || // Números de 0 a 9
        charCode === 44 || // Vírgula (,)
        charCode === 43 || // Sinal de mais (+)
        charCode === 45 // Sinal de menos (-)
    ) {
        return true;
    }
    return false;
}

function validateInput(input) {
    var value = input.value;
    if (!/\d/.test(value)) {
        //Apenas números na txt
        document.getElementById('errorMsgTXT').style.display = 'block';
    } else {
        document.getElementById('errorMsgTXT').style.display = 'none';
    }
}