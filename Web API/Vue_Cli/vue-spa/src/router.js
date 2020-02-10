import Vue from 'vue'
import About from './components/About.vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter);

export default new VueRouter({
    mode: "history",

    routes: [
        {
            path: "/",
            name: "home",
            // meta: {layout: "no-sidebar"},
            component: require("./components/Home.vue").default
        },
        {
            path: "/about",
            name: "about",
            // const component: () => import("./components/About.vue")
            component: About
        }
        // {
        //     path: "*",
        //     name: "404*",
        //     component: require("./layouts/error.vue").default
        // }
    ]
});