<template>
  <section id="service" class="container-fluid " style="margin-top: 100px;">
    <h1 class="text-white fs-8 ">У НАС ВЫ НАЙДЕТЕ</h1>
    <div class="row justify-content-between rowsp" style="margin-top: 100px;">
      <div class="col-lg-5">
        <div v-for="(service, index) in services" class="d-flex justify-content-start mb-2 jsc align-items-center">
          <div class="bg-green1 p-4 me-4 rounded-3 " style="font-size: 24px;color:dark">{{index+1}}</div>
          <p class="text-white mb-0">{{service.description}}</p>
        </div>
      </div>
      <div class="col-lg-5">
        <img src="../assets/bg2.png" class="border border-1 border-green1 rounded-2 w-100" style="height: 350px;" alt="">
      </div>
    </div>
  </section>
</template>

<script setup>
import {onMounted, ref} from "vue";
import {api} from "../api.js"
const services = ref([])
onMounted(async ()=>{
  const result = await api.get("services");
  services.value = result.data;
})
</script>

<style lang="scss"
       scoped>

</style>