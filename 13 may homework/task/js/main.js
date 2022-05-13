var li = ["erik", "alma", "armud", "uzum", "ciyelek", "gavali"];
$("button").click(function () {
    var list = $('#basket');
    var newfruit = $('#newfruit').val();
    var isValidFruit = $.inArray(newfruit, li) > -1;
    if (isValidFruit) {
        $('#meyveler').html(newfruit);
        var entry = $('<li></li>').text(newfruit);
        list.append(entry);
    }else{
      alert('Not valid');  
    }
});
DEMO