const box = document.querySelector(".row");

fetch("https://restcountries.com/v3.1/all").then(response => response.json())
.then(data => data.forEach(country =>{
    box.innerHTML += `
    <div class="col-md-3">
     <div class="card" style="width: 18rem;">
     <img src="${country.flags.png}"class="card-img-top"alt="...">
        <div class="card-body">
          <h5 class="card-title">Country:${country.name.common}</h5>
          <p class="card-text">Population:${country.population}</p>
          <p class="card-region">Region:${country.region}</p>
          <p class="card-capital">Capital:${country.capital}</p>
        </div>
      </div>
    </div>
    `
}));