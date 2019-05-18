<template>
<h1>{{msg}}</h1>
</template>

<script>
  import Vue from 'vue'
  import VueNotifications from 'vue-notifications'
  import iziToast from 'izitoast'
  import 'izitoast/dist/css/iziToast.min.css'
  function toast ({title, message, type, timeout, cb}) {
    if (type === VueNotifications.types.warn) type = 'warning'
    return iziToast[type]({title, message, timeout})
  }
  var options = {
    success: toast,
    error: toast,
    info: toast,
    warn: toast
  }
  Vue.use(VueNotifications, options)
  export default {
    name:'Notifications',
    data(){
      return{
        msg:'Notifications',
      }
    },
    methods:{
      doit(){
        var arr = [
          {title: '警告', message: '绿巨人和雷神即将开战！'
            , type: 'warn', timeout: 10000},
          {title: '成功', message: '欧阳峰已经完成九阳神功第一层修炼，张无忌老师表示很满意'
            , type: 'success', timeout: 10000},
          {title: '错误', message: '林平之忍着剧痛翻开《葵花宝典》第二页，上书“若不自宫，也能成功”'
            , type: 'error', timeout: 10000},
          {title: '信息', message: '林超英撩汉指数再创新低，王重阳表示出家向道'
            , type: 'info', timeout: 10000},
        ]
        var t = arr[Math.floor(Math.random() * 4)]
        this.showLoginError(t)
      }
    },
    notifications: {
      showLoginError: {
        title: 'Login Failed',
        message: 'Failed to authenticate',
        type: 'error' // You also can use 'VueNotifications.types.error' instead of 'error'
      }
    }
  }
</script>
