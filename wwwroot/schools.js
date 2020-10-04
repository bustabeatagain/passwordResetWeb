window.addEventListener("load", event => {
    getSchools();
});
let getSchools = () => {
    // let data = [
    //     {id: 1, name: "Neal"},
    //     {id: 2, name: "Southern High"},
    //     {id: 3, name: "Githens"}
    // ];
    // populateSelect(data);
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