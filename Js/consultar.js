document.addEventListener("DOMContentLoaded", function(){

    const idInput =document.getElementById("id_P");

    const resultContainer = document.getElementById("resultContainer");

    const searchButton = document.getElementById("searchButton");

    searchButton.addEventListener("click", function(){

    const id = idInput.value;

    const apiUrl =`https://localhost:44353/api/productos/${id}`;
 
    fetch (apiUrl)
    .then(response=>{
    if (response.ok){

    return response.json();


    }else{

   throw new Error("error al buscar");

    }
    })
    .then(data => {

        resultContainer.innerHTML = JSON.stringify(data, null, 2);
    })

    .catch(error => {

        console.error(error);
        resultContainer.innerHTML = "error al buscar el registro";
    });

});

});
