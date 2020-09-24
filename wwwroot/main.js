let getItems = () => {
    fetch("weatherforecast")
        .then(response => response.json())
        .then(data => displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
};

let displayItems = data => {
    let element = document.querySelector("#weather");
    element.innerHTML = JSON.stringify(data);
};