<template>
  <div id="HelloWorld" class="text-xs-center box">
      <div v-swiper:mySwiper="swiperOption" class="inbox">
        <div class="swiper-wrapper">
          <div class="swiper-slide" v-for="(banner,i) in banners" :key="'key'+i">
            <img class='boxitem' :src='banner'>
          </div>
        </div>
        <div class="swiper-pagination"></div>
      </div>
  </div>
</template>
<script>
import Vue from 'vue'
if (process.browser) {
  const VueAwesomeSwiper = require('vue-awesome-swiper/dist/ssr')
  Vue.use(VueAwesomeSwiper)
}
import 'swiper/dist/css/swiper.css'


  export default {
     name: 'HelloWorld',
    data() {
      return {
        banners: ['../static/logo.png','../static/logo.png'],
        swiperOption: {
          effect:'cube',
          autoplay:true,
          delay:10,
          speed:1200,
          pagination: {
            el: '.swiper-pagination',
            dynamicBullets: true
          },
        },
      }
    },
  }
</script>
