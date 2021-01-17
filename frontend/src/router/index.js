import Vue from "vue";
import VueRouter from "vue-router";

import Home from "@/views/Home.vue";
Vue.use(VueRouter);

// TODO Web Template Studio: Add routes for your new pages here.
export default new VueRouter({
  mode: "history",
  routes: [
    { path: "/", component: Home },

  ]
});
