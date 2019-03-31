
$(document).ready(function () {

    $("select").each(function () {
        setBackgroundColor($(this));
    });

    //load select control items' background color on page load
    $("select option").each(function () {
        setBackgroundColor($(this));
    });

});

function setBackgroundColor(object) {
    var color = "black";

    //Switch statement to change the band color in resistor figure when its respective select control's select value changes
    switch (object.attr('id')) {
        case "drpFirstBand":
            SetFigureBandColor($("#divBandFirst"), object);
            break;
        case "drpSecondBand":
            SetFigureBandColor($("#divBandSecond"), object);
            break;
        case "drpThirdBand":
            SetFigureBandColor($("#divBandThird"), object);
            break;
        case "drpFourthBand":
            SetFigureBandColor($("#divBandFourth"), object);
            break;
        default:
    }

    // Set background color of select items 
    if (object.val() != '') {

        object.css('background-color', object.val());

        switch (object.val()) {
            case "black":
                color = "white";
                break;
            case "red":
                color = "white";
                break;
            case "green":
                color = "white";
                break;
            case "brown":
                color = "white";
                break;
            case "blue":
                color = "white";
                break;
            case "gray":
                color = "white";
                break;
            default:

        }
        object.css('color', color);
    }
}