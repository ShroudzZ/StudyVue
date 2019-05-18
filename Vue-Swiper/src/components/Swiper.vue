<template>
  <div id="Swiper">
    <h1>{{msg}}</h1>
     <div>
      <router-link to="/HelloWorld">Swiper</router-link>
      <router-link to="/Notifications">Notifications</router-link>

    </div>
  </div>
</template>
<script>
export default {
  name: "Swiper",
  data() {
    return {
      msg: "Shroud"
    };
  }
};
</script>
