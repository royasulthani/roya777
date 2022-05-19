var btn = document.querySelector(".btn-primary");
var search = document.querySelector(".search");
var select = document.querySelector(".form-select");
var spanCity = document.getElementById("spanCity");
var sky = document.getElementById("sky");
var forecast = document.getElementById("forecast");
var cnt = document.getElementById("cnt");
btn.addEventListener("click",function(e){
    var axtarilan = search.value;
    let type = select.value;

    let data = SearchData(axtarilan,type);

   
})


async function SearchData(city,type){
    let data = await GetData(city);
    var seherAdi = data.location.name;
    var countryAdi = data.location.country;
    var temp_c = data.current.temp_c;
    var temp_f = data.current.temp_f;
    var iconSrc = "https:"+data.current.condition.icon;
    var weatherText = data.current.condition.text;
    spanCity.innerText = seherAdi;
    sky.innerHTML = `<img src="${iconSrc}"> ${weatherText}`;
    if(type=="c"){
        forecast.innerText = temp_c;
    } else {
        forecast.innerText = temp_f;

    }
    cnt.innerText = countryAdi;
}



async function GetData(city){
    let data = await fetch("https://api.weatherapi.com/v1/current.json?key=6bc15cfb31414fbda9f95625221905&q="+city);
    data = await data.json();
    return data;
}