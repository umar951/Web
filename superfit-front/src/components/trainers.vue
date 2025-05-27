<template>
  <section id="trainers" class="container-fluid " style="margin-top: 100px;">

    <div class="d-flex justify-content-between align-items-center">
      <h1 class="text-white fs-8">НАШИ ТРЕНЕРЫ</h1>
      <div>
        <button type="button" class="btn bg-green1"  style="    font-size: 40px;color: white;" data-bs-target="#trainersCarousel" data-bs-slide="prev">&lt;</button>
        <button type="button" class="btn bg-green1" style="    font-size: 40px;color: white;" data-bs-target="#trainersCarousel" data-bs-slide="next">&gt;  </button>
      </div>
    </div>

    <div id="trainersCarousel" class="carousel slide mt-4" data-bs-ride="carousel">
      <div class="carousel-inner">

        <div class="carousel-item active">
          <div class="row justify-content-center">
            <div class="col-lg-12 text-center position-relative">
              <img src="../assets/bg1.jpg" class="img-fluid rounded-3" style="border: 2px solid #25EC39;" alt="Анна Петрова">

              <div class="position-absolute top-0 w-50 " style="left:24px;">
                <h1 class="text-green1 fw-light mt-3">Анна Петрова</h1>
                <p class="text-white fw-bold">тренерский стаж - 5 лет.</p>
                <p class="text-white">Анна специализируется на тренировках по йоге и пилатесу. Она поможет вам улучшить гибкость, силу и баланс.</p>
              </div>
            </div>
          </div>
        </div>

        <div class="carousel-item">
          <div class="row justify-content-center">
            <div class="col-lg-12 text-center">
              <img src="../assets/bg1.jpg" class="img-fluid rounded-3" style="border: 2px solid #25EC39;" alt="Сергей Сидоров">
              <h1 class="text-green1 fw-light mt-3">Сергей Сидоров</h1>
              <p class="text-white fw-bold">тренерский стаж - 7 лет.</p>
              <p class="text-white">Сергей специализируется на тренировках по кроссфиту и функциональному тренингу. Он поможет вам улучшить выносливость, силу и скорость.</p>
            </div>
          </div>
        </div>

        <div class="carousel-item">
          <div class="row justify-content-center">
            <div class="col-lg-12 text-center">
              <img src="../assets/bg1.jpg" class="img-fluid rounded-3" style="border: 2px solid #25EC39;" alt="Олег Михайлов">
              <h1 class="text-green1 fw-light mt-3">Олег Михайлов</h1>
              <p class="text-white fw-bold">тренерский стаж - 8 лет.</p>
              <p class="text-white">Олег специализируется на тренировках по боксу и кикбоксингу. Он поможет вам улучшить реакцию, силу и выносливость.</p>
            </div>
          </div>
        </div>

      </div>
    </div>







  </section>
</template>

<script setup>

</script>

<style lang="scss"
       scoped>

</style>