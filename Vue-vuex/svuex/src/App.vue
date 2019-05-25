<template>
  <div id="app">
    <h1>{{count}}</h1>
    <p>
      <button @click="plus">+</button>
      <button @click="reduce">-</button>
    </p>

    <h1>{{c1}}</h1>
    <!-- <p>
      <button @click="plus">+</button>
      <button @click="reduce">-</button>
    </p> -->
    <!-- <img src="./assets/logo.png">
    <router-view/> -->
  </div>
</template>

<script>
export default {
  name: 'App',
  data(){
    return{

    }
  },
  mounted(){
    let i=0;
    setInterval(()=>{
      this.$store.commit('updateCount',i++)
    },1000);
  },
  methods:{
    plus(){
      this.$store.commit('plusCount',1)
    },
    reduce(){
      this.$store.commit('reduceCount',1)
    }
  },
  computed:{
    count(){
      return this.$store.state.count
    },
    c1(){
      return this.$store.state.c
    }
  }
}
</script>

<style scoped>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
button{
  font-size: 24px;
  color: #2c3e50;
  width: 100px;
  height: 35px;
}
</style>
