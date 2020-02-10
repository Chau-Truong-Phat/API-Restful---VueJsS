export const CustomerService = {
    getCustomers(axios){
        return axios.get('https://localhost:44351/api/customer/GetCustomers')
            .then(resp => {
                return resp.data
            })
            .catch(error => {
                console.log(error.response)
            });
    }
}
export default CustomerService