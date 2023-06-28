async function getAllSocios() {
    let url = 'https://localhost:7013/api/Socio/get-all';
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