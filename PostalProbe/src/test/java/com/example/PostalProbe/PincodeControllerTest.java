package com.example.PostalProbe;

import com.example.PostalProbe.controller.PincodeController;
import com.example.PostalProbe.entity.Pincode;
import com.example.PostalProbe.service.PincodeService;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.test.context.bean.override.mockito.MockitoBean;
import org.springframework.http.MediaType;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.request.MockMvcRequestBuilders;

import java.util.Arrays;
import java.util.List;

import static org.mockito.Mockito.when;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.jsonPath;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;
import static org.hamcrest.Matchers.hasSize;

@WebMvcTest(PincodeController.class)
public class PincodeControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @MockitoBean
    private PincodeService pincodeService;

    @Test
    public void getAllPincodeRecordsTest() throws Exception {
        Pincode pincode1 = new Pincode(); // Initialize fields
        Pincode pincode2 = new Pincode(); // Initialize fields
        List<Pincode> pincodes = Arrays.asList(pincode1, pincode2);

        when(pincodeService.getAllPincodes()).thenReturn(pincodes);

        mockMvc.perform(MockMvcRequestBuilders.get("/getallpincoderecords")
                        .contentType(MediaType.APPLICATION_JSON)) // Set content type here
                .andExpect(status().isOk())
                .andExpect(jsonPath("$", hasSize(2)));
    }
}
