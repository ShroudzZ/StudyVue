import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import Notifications from '@/components/Notifications'
import Swiper from '@/components/Swiper'
Vue.use(Router)

export default new Router({
  routes: [
    {
      path:'/',
      component:HelloWorld
    },
    {
      path: '/',
      name: 'Swiper',
      component: Swiper

    },
    {
      path:'/',
      name:'Notifications',
      component:Notifications
    }
  ],
  mode:'history'
})
