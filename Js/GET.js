let url= "https://localhost:44353/api/Productos"; // Reemplaza esto con la URL real de tu API de productos



fetch(url)
  .then( response => response.json() )
  .then( data => mostrarData(data) )
  .catch( error => console.log(error) )
  const mostrarData = (data) => {
    console.log(data)
    let body = ""
    
    for (var i = 0; i < data.length; i++) {      
       body+= `<tr><td>${data[i].Nombre}</td><td>${data[i].Descripcion}</td><td>${data[i].Precio}</td><td>${data[i].Stock}</td><td><img src="${data[i].Imagen}" alt="Imagen" width="100px" height="100px"> </td></tr>`
    }
    document.getElementById('data').innerHTML = body
    //console.log(body)
}
