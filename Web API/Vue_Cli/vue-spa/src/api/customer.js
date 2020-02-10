export const CustomerService = {
    getCustomers(axios){
        return axios
        .get("https://localhost:44351/api/customer/GetCustomers")
        .then(resp => {
            return resp
        })
        //  .catch(error => {
        //      return error.response.data.error.message
        //  })
    }
}
export default CustomerService