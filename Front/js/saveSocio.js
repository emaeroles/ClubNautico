function dataSaveSocio() {
    let nombre = document.getElementById('nombre').value;
    let apellido = document.getElementById('apellido').value;
    let telefono = document.getElementById('telefono').value;
    let socio = {'nombre': nombre, 'apellido': apellido, 'telefono': telefono };
    return socio;
}

async function postSocio(socio) {
    let socio = dataSaveSocio();
    let url = 'https://localhost:7013/api/Socio/save';
    try {
        let response = await fetch(url, {
            method: 'post',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify(socio)
        });
        if(response.ok){
            let data = await response.json();
            return data;
        }
    } catch (e) {
        console.log(e);
    }
}