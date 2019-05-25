import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    count: 0,
    c: 0
  },
  mutations: {
    updateCount(state, num) {
      state.c = num
    },
    plusCount(state, num) {
      state.count += num
    },
    reduceCount(state, num) {
      state.count -= num
    }
  }
})
