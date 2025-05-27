<template>
  <section id="plus" class="container-fluid">
    <h1 class="text-white fs-8">Преимущества</h1>
    <div class="d-flex flex-wrap  align-items-stretch justify-content-center gap-5 px-3">
      <div v-for="(adv,index) in advantages" style="width:400px" class="col-lg-3 mt-4  p-2 bg-greys rounded-3">
        <div class="d-flex justify-content-start align-items-center">
          <div class="bg-green1 d-flex justify-content-center align-items-center rounded-3 me-2"
               style="width: 50px; height: 50px;">
            <p class="m-0 fs-2 fw-bold">{{index +1}}</p>
          </div>
          <h1 class="text-green1 fs-3 fs-3s m-0">{{adv.caption.split(' ')[0]}} <br> {{adv.caption.split(' ')[1]}}</h1>
        </div>
        <p class="text-white mt-4">
          {{adv.description}}
        </p>
      </div>


    </div>

  </section>
</template>

<script setup>


import {onMounted, ref} from "vue";
import {api} from "../api.js"
const advantages = ref([])
onMounted(async ()=>{
 const result = await api.get("advantages");
  advantages.value = result.data;
})
</script>

<style lang="scss"
       scoped>

</style>