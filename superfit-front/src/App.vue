<script setup>

import HeaderMain from "./components/HeaderMain.vue"
import advantages from "./components/advantages.vue"
import services from "./components/services.vue"
import trainers from "./components/trainers.vue"
import follow from "./components/follow.vue"
import aboutUs from "./components/about-us.vue"
import contacts from "./components/contacts.vue"
</script>

<template>
  <HeaderMain/>
  <main class="mt-5">
<advantages/>

<services/>
<trainers/>
<follow/>
    <about-us/>
    <contacts/>
  </main>
</template>

<style scoped>

</style>
