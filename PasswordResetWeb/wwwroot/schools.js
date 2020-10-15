window.addEventListener("load", event => {
    getSchools();
});
let getSchools = () => {
    fetch("schools")
        .then(response => response.json())
        .then(data => populateSelect(data))
        .catch(error => console.error('Unable to get items.', error));
};

let populateSelect = data => {
    let select = document.querySelector("#schools");
    data.forEach(school => {
        let option = document.createElement("option");
        option.setAttribute("value", school.id);
        option.innerHTML = school.name;
        select.appendChild(option);
    });
};