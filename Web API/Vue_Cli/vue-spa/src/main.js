import Vue from 'vue'
import App from './App.vue'
// import VueRouter from 'vue-router'
import router from './router'

// const routes = [
//   { path: '/', component: Home },
//   { path: '/about', component: About }
// ]
// const router = new VueRouter({
//   routes, // short for routes: routes
//   mode: 'history'
// })

Vue.config.productionTip = false;

new Vue({
  // el: '#app',
  // template: '<App/>',
  // components: { App },
  router,
  render: h => h(App)
}).$mount('#app')
