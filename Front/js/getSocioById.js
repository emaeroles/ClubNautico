function dataGetSocioById(){
    let id = document.getElementById('id').value;
    return id;
}

async function getSocioById(id) {
    let id = dataGetSocioById();
    let url = 'https://localhost:7013/api/Socio/get-by-id/' + id;
    try {
        let response = await fetch(url, {
            method: "get"
        });
        if(response.ok){
            let data = await response.json();
            return data;
        }
    } catch (e) {
        console.log(e);
    }
}