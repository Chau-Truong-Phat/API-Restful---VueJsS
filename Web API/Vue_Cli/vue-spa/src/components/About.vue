<template>
  <div id="about">
  When you have a great story about how your product or service was built to change lives, share it. The "About Us" page is a great place for it to live, too. Good stories humanize your brand, providing context and meaning for your product. What’s more, good stories are sticky -- which means people are more likely to connect with them and pass them on.

  <!-- {{data}} -->
  </div>
</template>

<script>

// import axios from 'axios'
// import CustomerService from "./api/customer.js"

export default {
  name: 'about',
  data(){
    return {
      data: null
    }
  },
  computed: {

  },
  mounted() {
    // this.getCustomers()
  },
  methods: {
    // getCustomers(){
    //   return CustomerService.getCustomers(this.$axios).then(
    //     resp => {
    //       this.data = resp;
    //   })
    // }
  },
}
</script>
<!-- styling for the component -->
<style>
#about {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>