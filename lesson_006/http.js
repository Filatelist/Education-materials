var endpoint = 'https://gist.githubusercontent.com/Miserlou/c5cd8364bf9b2420bb29/raw/2bf258763cdddd704f8ffd3ea9a3e81d25e2c6f6/cities.json',
    searchInput = document.querySelector('.search'),
    suggestions = document.querySelector('.suggestions'),
    cities = [];

fetch(endpoint)
    .then(function (blob) { return blob.json() })
    .then(function (data) { return cities.push(...data) })
    .catch(function (error) { console.log(error) });
function findMatches(wordToMatch, cities) {
    return cities.filter(function (place) {
        var regexp = new RegExp(wordToMatch, 'gi');
        return place.city.match(regexp);
    })
}
function displayMatches(event) {
    var matchArray = findMatches(this.value, cities);
    var li;
    if (searchInput ==='') {
        searchInput.style.displayMatches = 'none';
    }
    suggestions.innerHTML = matchArray.map(function (place) {
        return "<li>" + place.city + "</li>";
    }).join('');
}
searchInput.addEventListener('keydown', displayMatches);
